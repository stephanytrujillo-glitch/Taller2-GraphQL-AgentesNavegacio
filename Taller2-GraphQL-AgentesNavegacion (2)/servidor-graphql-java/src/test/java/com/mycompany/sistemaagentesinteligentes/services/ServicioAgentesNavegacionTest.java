package com.mycompany.sistemaagentesinteligentes.services;

import com.mycompany.sistemaagentesinteligentes.exception.AgenteNoEncontradoException;
import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacion;
import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacionInput;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ServicioAgentesNavegacionTest {

    private ServicioAgentesNavegacion servicio;

    private AgenteNavegacionInput input(int id, String nombre, String estado) {
        return new AgenteNavegacionInput(id, nombre, 50.0, estado, 80.0, "Origen", "Destino", 90.0,
                "2026-09-01T10:00:00");
    }

    @BeforeEach
    void setUp() throws Exception {
        servicio = new ServicioAgentesNavegacion(); // inicia con 3 agentes de prueba
    }

    @Test
    void adicionarYConsultar() throws Exception {
        servicio.adicionar(input(10, "Nuevo", "activo"));
        assertTrue(servicio.buscarPorId(10).isPresent());
        assertEquals("ACTIVO", servicio.buscarPorId(10).get().getEstadoOperativo());
        assertEquals(4, servicio.listarTodos().size());
    }

    @Test
    void noPermiteIdRepetido() {
        assertThrows(Exception.class, () -> servicio.adicionar(input(1, "Otro", "ACTIVO")));
    }

    @Test
    void filtraEnServidorPorNombreYEstado() {
        assertEquals(1, servicio.listarPorFiltro("navibot", null).size());
        assertEquals(1, servicio.listarPorFiltro(null, "MANTENIMIENTO").size());
        assertEquals(0, servicio.listarPorFiltro("navibot", "INACTIVO").size());
    }

    @Test
    void actualizaYCalculaRendimiento() throws Exception {
        AgenteNavegacion a = servicio.actualizar(input(2, "Editado", "INACTIVO"));
        assertEquals("Editado", a.getNombre());
        assertEquals(85.0, a.calcularRendimiento(), 0.001);
    }

    @Test
    void eliminaYFallaSiNoExiste() throws Exception {
        servicio.eliminar(3);
        assertTrue(servicio.buscarPorId(3).isEmpty());
        assertThrows(AgenteNoEncontradoException.class, () -> servicio.eliminar(3));
    }

    @Test
    void rechazaDatosInvalidos() {
        assertThrows(Exception.class, () -> servicio.adicionar(input(20, "X", "APAGADO")));
        assertThrows(Exception.class, () -> servicio.adicionar(new AgenteNavegacionInput(21, "X", 150.0,
                "ACTIVO", 80.0, "A", "B", 90.0, "2026-09-01T10:00:00")));
    }
}
