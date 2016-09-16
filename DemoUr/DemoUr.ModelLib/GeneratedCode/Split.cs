internal class Split : Field
{
    public Field AlternativeNext { get; set; }


    public override Field NextField
    {
        get
        {
            //op basis van kleur de juiste nextField teruggeven
            return null;
        }

    }


}
