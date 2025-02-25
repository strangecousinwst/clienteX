using System;

public class Funcionarios {
	private int id;
	private String nome;
	private String contacto;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public String GetNome() {
		return this.nome;
	}
	public void SetNome(ref String nome) {
		this.nome = nome;
	}
	public String GetContacto() {
		return this.contacto;
	}
	public void SetContacto(ref String contacto) {
		this.contacto = contacto;
	}

}
