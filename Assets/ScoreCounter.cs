using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreCounter{
	static int score = 0;

	public static void Reset(){
		score = 0;
	}

	public static void Add(int point){
		score += point;
	}

	public static int CurrentScore(){
		return score;
	}
}
