using System;

public class Servicos {
	private int id;
	private String descricao;
	private Cliente cliente;
	private List<Processo> processos;
	private estado estado;
	private prioridade prioridade;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public String GetDescricao() {
		return this.descricao;
	}
	public void SetDescricao(ref String descricao) {
		this.descricao = descricao;
	}
	public Cliente GetCliente() {
		return this.cliente;
	}
	public void SetCliente(ref Cliente cliente) {
		this.cliente = cliente;
	}
	public void<Processo> GetProcessos() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetProcessos(ref object<Processo> processos) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void GetEstado() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetEstado(ref object estado) {
		throw new System.NotImplementedException("Not implemented");
	}
	public prioridade GetPrioridade() {
		return this.prioridade;
	}
	public void SetPrioridade(ref prioridade prioridade) {
		this.prioridade = prioridade;
	}

}
