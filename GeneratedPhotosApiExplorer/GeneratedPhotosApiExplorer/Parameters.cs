using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratedPhotosApiExplorer
{
    public class Parameters
    {
        private readonly Ethnicity ethnicity;
        private readonly Gender gender;
        private readonly Age age;

        public Parameters(Ethnicity ethnicity, Gender gender, Age age)
        {
            this.ethnicity = ethnicity;
            this.gender = gender;
            this.age = age;
        }

        public override string ToString() => string.Join("&", GetStrings().ToList());

        private IEnumerable<string> GetStrings()
        {
            yield return $"{nameof(Ethnicity).ToLower()}={ethnicity.ToString().ToLower()}";
            yield return $"{nameof(Gender).ToLower()}={gender.ToString().ToLower()}";
            yield return $"{nameof(Age).ToLower()}={age.ToString().ToLower().Replace("_", "-")}";
        }
    }

}


