package com.mycompany.sistemaagentesinteligentes.exception;

/** Se lanza cuando se intenta actualizar o eliminar un agente que no existe. */
public class AgenteNoEncontradoException extends Exception {

    public AgenteNoEncontradoException(int idAgente) {
        super("No existe un agente de navegacion con ID " + idAgente);
    }
}
