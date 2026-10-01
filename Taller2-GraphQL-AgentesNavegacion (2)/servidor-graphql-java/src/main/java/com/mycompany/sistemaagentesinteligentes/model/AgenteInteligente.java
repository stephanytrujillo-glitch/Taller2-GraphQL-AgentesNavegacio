package com.mycompany.sistemaagentesinteligentes.model;

/**
 * Clase A del diagrama de clases (tomada del Proyecto 1).
 * Atributos comunes a todos los agentes inteligentes.
 *
 * @author Juan Acuña, Luis Hernández, Stephany Trujillo
 */
public abstract class AgenteInteligente {

    private int idAgente;
    private String nombre;
    private double nivelAutonomia;
    private String estadoOperativo;
    private double nivelConfianza;

    public AgenteInteligente(int idAgente, String nombre, double nivelAutonomia, String estadoOperativo,
                             double nivelConfianza) throws Exception {
        setIdAgente(idAgente);
        setNombre(nombre);
        setNivelAutonomia(nivelAutonomia);
        setEstadoOperativo(estadoOperativo);
        setNivelConfianza(nivelConfianza);
    }

    public int getIdAgente() {
        return idAgente;
    }

    public void setIdAgente(int idAgente) throws Exception {
        if (idAgente <= 0) {
            throw new Exception("El ID del agente debe ser un numero entero positivo (mayor que 0)");
        }
        this.idAgente = idAgente;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) throws Exception {
        if (nombre == null || nombre.isBlank()) {
            throw new Exception("El nombre del agente es obligatorio");
        }
        this.nombre = nombre.trim();
    }

    public double getNivelAutonomia() {
        return nivelAutonomia;
    }

    public void setNivelAutonomia(double nivelAutonomia) throws Exception {
        if (nivelAutonomia >= 0 && nivelAutonomia <= 100) {
            this.nivelAutonomia = nivelAutonomia;
        } else {
            throw new Exception("Nivel de autonomia debe estar entre 0 y 100");
        }
    }

    public String getEstadoOperativo() {
        return estadoOperativo;
    }

    public void setEstadoOperativo(String estadoOperativo) throws Exception {
        if (estadoOperativo != null && (estadoOperativo.equalsIgnoreCase("ACTIVO")
                || estadoOperativo.equalsIgnoreCase("INACTIVO")
                || estadoOperativo.equalsIgnoreCase("MANTENIMIENTO"))) {
            this.estadoOperativo = estadoOperativo.toUpperCase();
        } else {
            throw new Exception("Estado operativo invalido. Use ACTIVO, INACTIVO o MANTENIMIENTO");
        }
    }

    public double getNivelConfianza() {
        return nivelConfianza;
    }

    public void setNivelConfianza(double nivelConfianza) throws Exception {
        if (nivelConfianza >= 0 && nivelConfianza <= 100) {
            this.nivelConfianza = nivelConfianza;
        } else {
            throw new Exception("Nivel de confianza debe estar entre 0 y 100");
        }
    }

    /** Cada tipo de agente calcula su rendimiento con su propia formula (polimorfismo). */
    public abstract double calcularRendimiento();
}
