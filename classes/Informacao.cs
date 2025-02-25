using System;

public class Informacao {
	private Int id;
	private Cliente cliente;
	private Data data_Insercao;

	public Int GetId() {
		return this.id;
	}
	public void SetId(ref Int id) {
		this.id = id;
	}
	public Cliente GetCliente() {
		return this.cliente;
	}
	public void SetCliente(ref Cliente cliente) {
		this.cliente = cliente;
	}
	public Data GetData_Insercao() {
		return this.data_Insercao;
	}
	public void SetData_Insercao(ref Data data_Insercao) {
		this.data_Insercao = data_Insercao;
	}

}
