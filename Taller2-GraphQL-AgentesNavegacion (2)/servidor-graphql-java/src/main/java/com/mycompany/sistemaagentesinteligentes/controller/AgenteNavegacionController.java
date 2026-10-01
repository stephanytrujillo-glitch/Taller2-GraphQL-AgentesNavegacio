package com.mycompany.sistemaagentesinteligentes.controller;

import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacion;
import com.mycompany.sistemaagentesinteligentes.model.AgenteNavegacionInput;
import com.mycompany.sistemaagentesinteligentes.services.ServicioAgentesNavegacion;
import org.springframework.graphql.data.method.annotation.Argument;
import org.springframework.graphql.data.method.annotation.MutationMapping;
import org.springframework.graphql.data.method.annotation.QueryMapping;
import org.springframework.graphql.data.method.annotation.SchemaMapping;
import org.springframework.stereotype.Controller;

import java.time.format.DateTimeFormatter;
import java.util.List;

/**
 * Controlador GraphQL: expone el CRUD de AgenteNavegacion como Queries y Mutations
 * (ver resources/graphql/schema.graphqls).
 */
@Controller
public class AgenteNavegacionController {

    private static final DateTimeFormatter FORMATO_FECHA = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss");

    private final ServicioAgentesNavegacion servicio;

    public AgenteNavegacionController(ServicioAgentesNavegacion servicio) {
        this.servicio = servicio;
    }

    // =============================== QUERIES ===============================

    @QueryMapping
    public List<AgenteNavegacion> agentesNavegacion() {
        return servicio.listarTodos();
    }

    @QueryMapping
    public List<AgenteNavegacion> agentesNavegacionPorFiltro(@Argument String nombre, @Argument String estadoOperativo) {
        return servicio.listarPorFiltro(nombre, estadoOperativo);
    }

    @QueryMapping
    public AgenteNavegacion agenteNavegacionPorId(@Argument int idAgente) {
        return servicio.buscarPorId(idAgente).orElse(null);
    }

    // ============================== MUTATIONS ==============================

    @MutationMapping
    public AgenteNavegacion crearAgenteNavegacion(@Argument AgenteNavegacionInput input) throws Exception {
        return servicio.adicionar(input);
    }

    @MutationMapping
    public AgenteNavegacion actualizarAgenteNavegacion(@Argument AgenteNavegacionInput input) throws Exception {
        return servicio.actualizar(input);
    }

    @MutationMapping
    public AgenteNavegacion eliminarAgenteNavegacion(@Argument int idAgente) throws Exception {
        return servicio.eliminar(idAgente);
    }

    // ======================== CAMPOS CALCULADOS ========================

    /** GraphQL no tiene tipo fecha nativo: el LocalDateTime se envia como texto ISO. */
    @SchemaMapping(typeName = "AgenteNavegacion", field = "fechaUltimaCalibracion")
    public String fechaUltimaCalibracion(AgenteNavegacion agente) {
        return agente.getFechaUltimaCalibracion().format(FORMATO_FECHA);
    }

    /** Rendimiento calculado con el metodo polimorfico del Proyecto 1. */
    @SchemaMapping(typeName = "AgenteNavegacion", field = "rendimiento")
    public double rendimiento(AgenteNavegacion agente) {
        return agente.calcularRendimiento();
    }
}
