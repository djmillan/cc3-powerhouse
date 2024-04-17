﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus 
    {
        public Quest PlayerQuest { get; set; }
        public bool IsDone { get; set; }
        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsDone = false;
        }

    }
}
