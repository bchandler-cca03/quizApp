using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IQuestionRepository
    {
        List<Question> ListAll();

        Question GetById(int id);

        void AddQuestion(Question newQuestion);

        void UpdateQuestion(Question updateQuestion);

        void Delete(int id); 
    }
}
