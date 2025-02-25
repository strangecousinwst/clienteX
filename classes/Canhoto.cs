using System;

public class Canhoto {
	private int id;
	private cliente cliente;
	private categoria categoria;
	private funcionario funcionario;
	private String attribute;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public void GetCategoria() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetCategoria(ref object categoria) {
		throw new System.NotImplementedException("Not implemented");
	}
	public cliente GetCliente() {
		return this.cliente;
	}
	public void SetCliente(ref cliente cliente) {
		this.cliente = cliente;
	}
	public funcionario GetFuncionario() {
		return this.funcionario;
	}
	public void SetFuncionario(ref funcionario funcionario) {
		this.funcionario = funcionario;
	}
	public void GetAttribute() {
		return this.attribute;
	}
	public void SetAttribute(ref object attribute) {
		this.attribute = attribute;
	}

}
