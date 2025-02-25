using System;

public class Clientes {
	private int id;
	private String nome;
	private String localidade;
	private String contacto;
	private String tag;
	private Informacao informacao;
	private List<Movimento> movimentos;

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
	public String GetLocalidade() {
		return this.localidade;
	}
	public void SetLocalidade(ref String localidade) {
		this.localidade = localidade;
	}
	public String GetContacto() {
		return this.contacto;
	}
	public void SetContacto(ref String contacto) {
		this.contacto = contacto;
	}
	public String GetTag() {
		return this.tag;
	}
	public void SetTag(ref String tag) {
		this.tag = tag;
	}
	public Informacao GetInformacao() {
		return this.informacao;
	}
	public void<Movimento> GetMovimentos() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetMovimentos(ref object<Movimento> movimentos) {
		throw new System.NotImplementedException("Not implemented");
	}

}
