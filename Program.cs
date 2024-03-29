﻿using NHunspell;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        // Load the dictionary files
        using (Hunspell hunspell = new Hunspell("en_US.aff", "en_US.dic"))
        {
            // Example words to check
            string[] wordsToCheck = {"the", "of", "to", "and", "a", "in", "is", "it", "you", "that", "he", "was", "for", "on", "are", 
                "with", "as", "I", "his", "they", "be", "at", "one", "have", "this", "from", "or", "had", "by", "not", 
                "word", "but", "what", "some", "we", "can", "out", "other", "were", "all", "there", "when", "up", "use",
                "your", "how", "said", "an", "each", "she", "which", "do", "their", "time", "if", "will", "way", "about", 
                "many", "then", "them", "write", "would", "like", "so", "these", "her", "long", "make", "thing", "see",
                "him", "two", "has", "look", "more", "day", "could", "go", "come", "did", "number", "sound", "no", "most", 
                "people", "my", "over", "know", "water", "than", "call", "first", "who", "may", "down", "side", "been", "now", 
                "find", "any", "new", "work", "part", "take", "get", "place", "made", "live", "where", "after", "back", "little",
                "only", "round", "man", "year", "came", "show", "every", "good", "me", "give", "our", "under", "name", "very", "through", 
                "just", "form", "sentence", "great", "think", "say", "help", "low", "line", "deffer", "turn", "cause", "mich", "mean", "before",
                "move", "right", "boy", "old", "too", "same", "tell", "does", "set", "three", "want", "air", "well", "also", "play", "small",
                "end", "put", "home", "read", "hand", "port", "large", "spell", "add", "even", "land", "here", "must", "big", "high", "such", 
                "follow", "act", "why", "ask", "men", "change", "went", "light", "kind", "off", "need", "house", "picture", "try", "us", "again",
                "animal", "point", "mother", "world", "near", "build", "self", "earth", "father", "head", "stand", "own", "page", "should", "country",
                "found", "answer", "school", "grow", "study", "still", "learn", "plant", "cover", "food", "sun", "four", "between", "state", "keep", 
                "eye", "never", "last", "let", "thought", "city", "tree", "cross", "farm", "hard", "start", "might", "story", "saw", "far", "sea", 
                "draw", "left", "late", "run", "don't", "while", "press", "close", "night", "real", "life", "few", "north", "open", "seem", "together",
                "next", "white", "children", "begin", "got", "walk", "example", "ease", "paper", "group", "always", "music", "those", "both", "mark", 
                "often", "letter", "until", "mile", "river", "car", "feet", "care", "second", "book", "carry", "took", "science", "eat", "room", "friend",
                "began", "idea", "fish", "mountain", "stop", "once", "base", "hear", "horse", "cut", "sure", "watch", "color", "face", "wood", "main", 
                "enough", "plain", "girl", "usual", "young", "ready", "above", "ever", "red", "list", "though", "feel", "talk", "bird", "soon", "body",
                "dog", "family", "direct", "pose", "leave", "song", "measure", "door", "product", "black", "short", "numeral", "class", "wind", "question",
                "happen", "complete", "ship", "area", "half", "rock", "order", "fire", "south", "problim", "piece", "told", "knew", "pass", "since", "top", 
                "whole", "king", "space", "heard", "best", "hour", "better", "true", "during", "hundred", "five", "remember", "step", "early", "hold", "west",
                "ground", "interest", "reach", "fast", "verb", "sing", "listen", "six", "table", "travel", "less", "morning", "ten", "simple", "several", "vowwl",
                "toward", "war", "lay", "against", "pattern", "slow", "center", "love", "person", "money", "serve", "appear", "road", "mop", "rain", "rule", "govern", 
                "pull", "cold", "notice", "voice", "unit", "poer", "town", "fine", "certain", "fly", "fall", "lead", "cry", "dark", "machine", "note", "wait"};

            foreach (string word in wordsToCheck)
            {
                // Check if the word is misspelled
                bool isMisspelled = !hunspell.Spell(word);

                if (isMisspelled)
                {
                    Console.WriteLine($"\nMisspelled Word : {word}");
                    // Optionally, suggest corrections
                    var suggestions = hunspell.Suggest(word);
                    Console.WriteLine("\tSuggestions:");
                    foreach (string suggestion in suggestions)
                    {
                        Console.WriteLine($"\t\t {suggestion}");
                    }
                }
            }
        }

        Console.ReadLine();
    }
}