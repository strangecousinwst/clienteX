using System;

public class Telefonemas {
	private int id;
	private Funcionario funcionario;
	private cliente cliente;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public Funcionario GetFuncionario() {
		return this.funcionario;
	}
	public void SetFuncionario(ref Funcionario funcionario) {
		this.funcionario = funcionario;
	}
	public cliente GetCliente() {
		return this.cliente;
	}
	public void SetCliente(ref cliente cliente) {
		this.cliente = cliente;
	}

}
