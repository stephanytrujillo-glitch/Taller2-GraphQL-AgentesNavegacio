package com.mycompany.sistemaagentesinteligentes.model;

import java.time.LocalDateTime;

/**
 * Clase C del diagrama de clases (Proyecto 1): objeto gestionado en el Taller 2.
 *
 * Atributos gestionados (requisito: int, double, String, LocalDateTime y otro):
 *  - int            idAgente               (heredado)
 *  - String         nombre                 (heredado)
 *  - double         nivelAutonomia         (heredado, 0-100)
 *  - String         estadoOperativo        (heredado, ACTIVO / INACTIVO / MANTENIMIENTO)
 *  - double         nivelConfianza         (heredado, 0-100)
 *  - String         origen
 *  - String         destino
 *  - double         precisionGPS           (0-100)
 *  - LocalDateTime  fechaUltimaCalibracion (NUEVO para el Taller 2)
 *
 * @author Juan Acuña, Luis Hernández, Stephany Trujillo
 */
public class AgenteNavegacion extends AgenteInteligente implements IAplicable {

    private String origen;
    private String destino;
    private double precisionGPS;
    private LocalDateTime fechaUltimaCalibracion;

    public AgenteNavegacion(int idAgente, String nombre, double nivelAutonomia, String estadoOperativo,
                            double nivelConfianza, String origen, String destino, double precisionGPS,
                            LocalDateTime fechaUltimaCalibracion) throws Exception {
        super(idAgente, nombre, nivelAutonomia, estadoOperativo, nivelConfianza);
        setOrigen(origen);
        setDestino(destino);
        setPrecisionGPS(precisionGPS);
        setFechaUltimaCalibracion(fechaUltimaCalibracion);
    }

    public String getOrigen() {
        return origen;
    }

    public void setOrigen(String origen) throws Exception {
        if (origen == null || origen.isBlank()) {
            throw new Exception("El origen es obligatorio");
        }
        this.origen = origen.trim();
    }

    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) throws Exception {
        if (destino == null || destino.isBlank()) {
            throw new Exception("El destino es obligatorio");
        }
        this.destino = destino.trim();
    }

    public double getPrecisionGPS() {
        return precisionGPS;
    }

    public void setPrecisionGPS(double precisionGPS) throws Exception {
        if (precisionGPS >= 0 && precisionGPS <= 100) {
            this.precisionGPS = precisionGPS;
        } else {
            throw new Exception("La precision GPS debe estar entre 0 y 100");
        }
    }

    public LocalDateTime getFechaUltimaCalibracion() {
        return fechaUltimaCalibracion;
    }

    public void setFechaUltimaCalibracion(LocalDateTime fechaUltimaCalibracion) throws Exception {
        if (fechaUltimaCalibracion == null) {
            throw new Exception("La fecha de ultima calibracion es obligatoria");
        }
        if (fechaUltimaCalibracion.isAfter(LocalDateTime.now().plusMinutes(1))) {
            throw new Exception("La fecha de ultima calibracion no puede estar en el futuro");
        }
        this.fechaUltimaCalibracion = fechaUltimaCalibracion;
    }

    /** Promedia la precision GPS con el nivel de confianza (formula del Proyecto 1). */
    @Override
    public double calcularRendimiento() {
        double resultado = (precisionGPS + getNivelConfianza()) / 2.0;
        return Math.max(0, resultado);
    }

    /** Recalibra el sistema de navegacion: mejora la precision GPS y registra la fecha. */
    @Override
    public void aplicar() {
        this.precisionGPS = Math.min(100, this.precisionGPS + 5);
        this.fechaUltimaCalibracion = LocalDateTime.now();
    }
}
