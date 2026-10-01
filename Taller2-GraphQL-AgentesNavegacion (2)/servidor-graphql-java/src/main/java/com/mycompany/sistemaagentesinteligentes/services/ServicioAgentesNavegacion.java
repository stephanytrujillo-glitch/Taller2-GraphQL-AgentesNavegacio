package com.mycompany.sistemaagentesinteligentes.services;

import com.mycompany.sistemaagentesinteligentes.exception.AgenteNoEncontradoException;
import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacion;
import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacionInput;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.time.format.DateTimeParseException;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Optional;

/**
 * Logica central del servidor (Model).
 * Los agentes de navegacion se guardan en MEMORIA PRINCIPAL en una Lista.
 * Spring crea una unica instancia (singleton) compartida por todos los clientes;
 * por eso los metodos son synchronized.
 *
 * @author Juan Acuña, Luis Hernández, Stephany Trujillo
 */
@Service
public class ServicioAgentesNavegacion {

    private final List<AgenteNavegacion> agentes = new ArrayList<>();

    public ServicioAgentesNavegacion() throws Exception {
        cargarDatosDePrueba();
    }

    /** Agentes iniciales para que la demostracion no empiece vacia. */
    private void cargarDatosDePrueba() throws Exception {
        agentes.add(new AgenteNavegacion(1, "NaviBot Centro", 85.0, "ACTIVO", 90.0,
                "Universidad de Ibague", "Centro Comercial Multicentro", 95.5, LocalDateTime.of(2026, 9, 10, 8, 30)));
        agentes.add(new AgenteNavegacion(2, "RutaSegura Norte", 70.0, "MANTENIMIENTO", 75.5,
                "Terminal de Transportes", "Hospital Federico Lleras", 80.0, LocalDateTime.of(2026, 8, 25, 14, 0)));
        agentes.add(new AgenteNavegacion(3, "GuiaTolima", 60.0, "INACTIVO", 65.0,
                "Plaza de Bolivar", "Aeropuerto Perales", 70.25, LocalDateTime.of(2026, 7, 5, 17, 45)));
    }

    // =============================== LISTAR ===============================

    /** Variante 1: todos los agentes ordenados por ID. */
    public synchronized List<AgenteNavegacion> listarTodos() {
        List<AgenteNavegacion> copia = new ArrayList<>(agentes);
        copia.sort(Comparator.comparingInt(AgenteNavegacion::getIdAgente));
        return copia;
    }

    /**
     * Variante 2: filtrado del LADO DEL SERVIDOR con dos parametros opcionales.
     * @param nombre          texto contenido en el nombre (sin importar mayusculas). null/vacio = no filtra.
     * @param estadoOperativo ACTIVO, INACTIVO o MANTENIMIENTO. null/vacio = no filtra.
     */
    public synchronized List<AgenteNavegacion> listarPorFiltro(String nombre, String estadoOperativo) {
        String texto = (nombre == null) ? "" : nombre.trim().toLowerCase();
        String estado = (estadoOperativo == null) ? "" : estadoOperativo.trim();
        List<AgenteNavegacion> resultado = new ArrayList<>();
        for (AgenteNavegacion agente : agentes) {
            boolean cumpleNombre = texto.isEmpty() || agente.getNombre().toLowerCase().contains(texto);
            boolean cumpleEstado = estado.isEmpty() || agente.getEstadoOperativo().equalsIgnoreCase(estado);
            if (cumpleNombre && cumpleEstado) {
                resultado.add(agente);
            }
        }
        resultado.sort(Comparator.comparingInt(AgenteNavegacion::getIdAgente));
        return resultado;
    }

    // =============================== BUSCAR ===============================

    public synchronized Optional<AgenteNavegacion> buscarPorId(int idAgente) {
        for (AgenteNavegacion agente : agentes) {
            if (agente.getIdAgente() == idAgente) {
                return Optional.of(agente);
            }
        }
        return Optional.empty();
    }

    // ============================== ADICIONAR ==============================

    public synchronized AgenteNavegacion adicionar(AgenteNavegacionInput input) throws Exception {
        validarObligatorios(input);
        if (buscarPorId(input.idAgente()).isPresent()) {
            throw new Exception("Ya existe un agente con ID " + input.idAgente());
        }
        AgenteNavegacion nuevo = crearDesdeInput(input);
        agentes.add(nuevo);
        return nuevo;
    }

    // ============================== ACTUALIZAR ==============================

    public synchronized AgenteNavegacion actualizar(AgenteNavegacionInput input) throws Exception {
        validarObligatorios(input);
        AgenteNavegacion existente = buscarPorId(input.idAgente())
                .orElseThrow(() -> new AgenteNoEncontradoException(input.idAgente()));

        // Se valida todo primero en un objeto temporal: si algun dato es invalido
        // el agente original no queda modificado a medias.
        AgenteNavegacion validado = crearDesdeInput(input);

        existente.setNombre(validado.getNombre());
        existente.setNivelAutonomia(validado.getNivelAutonomia());
        existente.setEstadoOperativo(validado.getEstadoOperativo());
        existente.setNivelConfianza(validado.getNivelConfianza());
        existente.setOrigen(validado.getOrigen());
        existente.setDestino(validado.getDestino());
        existente.setPrecisionGPS(validado.getPrecisionGPS());
        existente.setFechaUltimaCalibracion(validado.getFechaUltimaCalibracion());
        return existente;
    }

    // =============================== ELIMINAR ===============================

    public synchronized AgenteNavegacion eliminar(int idAgente) throws Exception {
        AgenteNavegacion existente = buscarPorId(idAgente)
                .orElseThrow(() -> new AgenteNoEncontradoException(idAgente));
        agentes.remove(existente);
        return existente;
    }

    // ============================== UTILIDADES ==============================

    private AgenteNavegacion crearDesdeInput(AgenteNavegacionInput in) throws Exception {
        return new AgenteNavegacion(in.idAgente(), in.nombre(), in.nivelAutonomia(), in.estadoOperativo(),
                in.nivelConfianza(), in.origen(), in.destino(), in.precisionGPS(),
                convertirFecha(in.fechaUltimaCalibracion()));
    }

    private void validarObligatorios(AgenteNavegacionInput in) throws Exception {
        if (in == null || in.idAgente() == null || in.nombre() == null || in.nivelAutonomia() == null
                || in.estadoOperativo() == null || in.nivelConfianza() == null || in.origen() == null
                || in.destino() == null || in.precisionGPS() == null || in.fechaUltimaCalibracion() == null) {
            throw new Exception("Faltan datos obligatorios del agente");
        }
    }

    private LocalDateTime convertirFecha(String texto) throws Exception {
        try {
            return LocalDateTime.parse(texto.trim());
        } catch (DateTimeParseException e) {
            throw new Exception("La fecha debe tener el formato yyyy-MM-ddTHH:mm:ss (ej. 2026-09-30T14:30:00)");
        }
    }
}
