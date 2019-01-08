package shoppingExercise;

public class Email {
	
	private String subject;
	private String body;
	
	public Email(String subject,String body) {
		this.subject = subject;
		this.body = body;
	}
	
	public void readEmail() {
		System.out.println("Subject: " + subject );
		System.out.println(body);
	}

}
