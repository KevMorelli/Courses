package com.kev.topic7;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "currentlystudying")
public class StudySchedule {

	@Column(name = "StudentId")
	private int studentId;
	@Column(name = "CourseId")
	private int courseId;
	@Id//THIS DOESN'T GO HERE but was for testing the exercise
	@Column(name = "FirstPartialNote")
	private double firstPartialNote;
	@Column(name = "SecondPartialNote")
	private double secondPartialNote;
	@Column(name = "ThirdPartialNote")
	private double thirdPartialNote;
	@Column(name = "FinalNote")
	private double finalNote;

	public StudySchedule() {
	}

	public StudySchedule(int studentId, int courseId, double firstPartialNote, double secondPartialNote, double thirdPartialNote,
			double finalNote) {
		super();
		this.studentId = studentId;
		this.courseId = courseId;
		this.firstPartialNote = firstPartialNote;
		this.secondPartialNote = secondPartialNote;
		this.thirdPartialNote = thirdPartialNote;
		this.finalNote = finalNote;
	}

	public int getStudentId() {
		return studentId;
	}

	public void setStudentId(int studentId) {
		this.studentId = studentId;
	}

	public int getCourseId() {
		return courseId;
	}

	public void setCourseId(int courseId) {
		this.courseId = courseId;
	}

	public double getFirstPartialNote() {
		return firstPartialNote;
	}

	public void setFirstPartialNote(double firstPartialNote) {
		this.firstPartialNote = firstPartialNote;
	}

	public double getSecondPartialNote() {
		return secondPartialNote;
	}

	public void setSecondPartialNote(double secondPartialNote) {
		this.secondPartialNote = secondPartialNote;
	}

	public double getThirdPartialNote() {
		return thirdPartialNote;
	}

	public void setThirdPartialNote(double thirdPartialNote) {
		this.thirdPartialNote = thirdPartialNote;
	}

	public double getFinalNote() {
		return finalNote;
	}

	public void setFinalNote(double finalNote) {
		this.finalNote = finalNote;
	}

}
