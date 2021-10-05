using System;
using TriviaPorts;

namespace OperatingSystemsExam.Quiz
{
    public static class YesNoQuestions
    {
        public static IQuestion[] Questions { get; } = new YesNoQuestion[] {
            new YesNoQuestion()
            {
                Text = @"Journaling-Dateisysteme grenzen die bei der Konsistenzprüfung zu überprüfenden Daten ein.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Bei Dateisystemen mit Journal sind Datenverluste garantiert ausgeschlossen.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Der Zugriff auf Festplatten erfolgt blockorientiert und kann wahlfrei geschehen.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Round Robin kann als faires Schedulingverfahren bezeichnet werden.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Mit Prioritätengesteuertem Scheduling lässt sich die geringste Gesamtlaufzeit für Aufgaben erreichen.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Shortest Job First ist ein in der Praxis eingesetztes Schedulingverfahren.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Monolithische Betriebssystemkerne sind leichter zu erweitern und zu warten.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Defragmentieren ist auch bei SSDs nötig.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Die Funktion eines Mutex lässt sich auch mit Semaphoren erreichen.",
                Answer = true
            }
        };

        private class YesNoQuestion : IYesNoQuestion
        {
            public bool Answer { get; set; }
            public string Category { get; set; }
            public QuestionType QuestionType { get; set; }
            public Choices ChoicesType { get; set; }
            public Difficulty Difficulty { get; set; }
            public string Text { get; set; }
            public IQuestion AlternativeQuestion { get; set; }
        }

    }
}


