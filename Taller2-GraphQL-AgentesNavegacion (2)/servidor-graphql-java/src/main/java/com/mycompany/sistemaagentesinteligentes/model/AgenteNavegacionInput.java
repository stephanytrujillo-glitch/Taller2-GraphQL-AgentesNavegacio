package com.mycompany.sistemaagentesinteligentes.model;

/**
 * Datos que envia el cliente en las mutaciones crearAgenteNavegacion y actualizarAgenteNavegacion.
 * Corresponde al tipo "AgenteNavegacionInput" del esquema GraphQL.
 * La fecha llega como texto ISO (yyyy-MM-ddTHH:mm:ss) y el servicio la convierte a LocalDateTime.
 */
public record AgenteNavegacionInput(
        Integer idAgente,
        String nombre,
        Double nivelAutonomia,
        String estadoOperativo,
        Double nivelConfianza,
        String origen,
        String destino,
        Double precisionGPS,
        String fechaUltimaCalibracion) {
}
