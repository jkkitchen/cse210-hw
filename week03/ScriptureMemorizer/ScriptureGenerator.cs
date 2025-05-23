using System;

public class ScriptureGenerator
{
    //----Member Attributes----
    private List<Scripture> _scriptures;


    //----Constructor----
    public ScriptureGenerator()
    {
        _scriptures = new List<Scripture>();
    }

    //----Methods----
    public Scripture GetRandomScripture()
    {
        //Generate random number to use as index
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 3);



        //Create list of Scriptures

        //Scripture 1
        //Reference
        string scriptureBook1 = "D&C";
        int scriptureChapter1 = 50;
        int scriptureStartVerse1 = 23;
        Reference reference1 = new Reference(scriptureBook1, scriptureChapter1, scriptureStartVerse1);
        //Text
        string scriptureText1 = "And that which doth not edify is not of God, and is darkness.";
        //Create scripture and add to list
        Scripture scripture1 = new Scripture(reference1, scriptureText1);
        _scriptures.Add(scripture1);

        //Scripture 2
        //Reference
        string scriptureBook2 = "Alma";
        int scriptureChapter2 = 7;
        int scriptureStartVerse2 = 11;
        int scriptureEndVerse2 = 12;
        Reference reference2 = new Reference(scriptureBook2, scriptureChapter2, scriptureStartVerse2, scriptureEndVerse2);
        //Text
        string scriptureText2 = @"And he shall go forth, suffering pains and afflictions and temptations of every kind; and this
        that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will
        take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities,
        that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his
        people according to their infirmities.";
        //Create scripture and add to list
        Scripture scripture2 = new Scripture(reference2, scriptureText2);
        _scriptures.Add(scripture2);

        //Scripture 3        
        //Reference
        string scriptureBook3 = "Matthew";
        int scriptureChapter3 = 6;
        int scriptureStartVerse3 = 24;
        Reference reference3 = new Reference(scriptureBook3, scriptureChapter3, scriptureStartVerse3);
        //Text
        string scriptureText3 = @"No man can serve two masters: for either he will hate the one, and love the otehr; or else he will hold to the one, and
        despise the other. Ye cannot serve God and mammon.";
        //Create scripture and add to list
        Scripture scripture3 = new Scripture(reference3, scriptureText3);
        _scriptures.Add(scripture3);


        //Return random Scripture from the list
        Scripture scriptureToMemorize = _scriptures[number];
        return scriptureToMemorize;
    }

}