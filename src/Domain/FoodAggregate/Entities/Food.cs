using Domain.Common;
using Domain.FoodAggregate.ValueObjects;

namespace Domain.FoodAggregate.Entities;

/// <summary>
///     Represents a food entity with various nutritional properties.
/// </summary>
public sealed class Food(
    FoodId foodId,
    string? foodName,
    double? spiseligDel,
    double? vann,
    double? kilojouleKj,
    double? kilokalorierKcal,
    double? fett,
    double? mettet,
    double? c120G,
    double? c140,
    double? c160,
    double? c180,
    double? trans,
    double? enumettet,
    double? c161Sum,
    double? c181Sum,
    double? flerumettet,
    double? c182N6,
    double? c183N3,
    double? c203N3,
    double? c203N6,
    double? c204N3,
    double? c204N6,
    double? c205N3Epa,
    double? c225N3Dpa,
    double? c226N3Dha,
    double? omega3,
    double? omega6,
    double? kolesterolMg,
    double? karbohydrat,
    double? stivelse,
    double? monoPlusDisakk,
    double? sukkerTilsatt,
    double? kostfiber,
    double? protein,
    double? salt,
    double? alkohol,
    double? vitaminArae,
    double? retinolMug,
    double? betaKarotenMug,
    double? vitaminDMug,
    double? vitaminEAlfaTe,
    double? tiaminMg,
    double? riboflavinMg,
    double? niacinMg,
    double? vitaminB6Mg,
    double? folatMug,
    double? vitaminB12Mug,
    double? vitaminCMg,
    double? kalsiumMg,
    double? jernMg,
    double? natriumMg,
    double? kaliumMg,
    double? magnesiumMg,
    double? sinkMg,
    double? selenMug,
    double? kopperMg,
    double? fosforMg,
    double? jodMug)
    : Entity<FoodId>(foodId)
{
    /// <summary>
    ///     Gets the name of the food.
    /// </summary>
    public string? FoodName { get; init; } = foodName;

    /// <summary>
    ///     Gets the edible portion of the food.
    /// </summary>
    public double? SpiseligDel { get; init; } = spiseligDel;

    /// <summary>
    ///     Gets the water content of the food.
    /// </summary>
    public double? Vann { get; init; } = vann;

    /// <summary>
    ///     Gets the energy content in kilojoules.
    /// </summary>
    public double? KilojouleKJ { get; init; } = kilojouleKj;

    /// <summary>
    ///     Gets the energy content in kilocalories.
    /// </summary>
    public double? KilokalorierKcal { get; init; } = kilokalorierKcal;

    /// <summary>
    ///     Gets the fat content of the food.
    /// </summary>
    public double? Fett { get; init; } = fett;

    /// <summary>
    ///     Gets the saturated fat content of the food.
    /// </summary>
    public double? Mettet { get; init; } = mettet;

    /// <summary>
    ///     Gets the C12:0 fatty acid content of the food.
    /// </summary>
    public double? C12_0g { get; init; } = c120G;

    /// <summary>
    ///     Gets the C14:0 fatty acid content of the food.
    /// </summary>
    public double? C14_0 { get; init; } = c140;

    /// <summary>
    ///     Gets the C16:0 fatty acid content of the food.
    /// </summary>
    public double? C16_0 { get; init; } = c160;

    /// <summary>
    ///     Gets the C18:0 fatty acid content of the food.
    /// </summary>
    public double? C18_0 { get; init; } = c180;

    /// <summary>
    ///     Gets the trans fat content of the food.
    /// </summary>
    public double? Trans { get; init; } = trans;

    /// <summary>
    ///     Gets the monounsaturated fat content of the food.
    /// </summary>
    public double? Enumettet { get; init; } = enumettet;

    /// <summary>
    ///     Gets the C16:1 fatty acid content of the food.
    /// </summary>
    public double? C16_1Sum { get; init; } = c161Sum;

    /// <summary>
    ///     Gets the C18:1 fatty acid content of the food.
    /// </summary>
    public double? C18_1Sum { get; init; } = c181Sum;

    /// <summary>
    ///     Gets the polyunsaturated fat content of the food.
    /// </summary>
    public double? Flerumettet { get; init; } = flerumettet;

    /// <summary>
    ///     Gets the C18:2n-6 fatty acid content of the food.
    /// </summary>
    public double? C18_2n_6 { get; init; } = c182N6;

    /// <summary>
    ///     Gets the C18:3n-3 fatty acid content of the food.
    /// </summary>
    public double? C18_3n_3 { get; init; } = c183N3;

    /// <summary>
    ///     Gets the C20:3n-3 fatty acid content of the food.
    /// </summary>
    public double? C20_3n_3 { get; init; } = c203N3;

    /// <summary>
    ///     Gets the C20:3n-6 fatty acid content of the food.
    /// </summary>
    public double? C20_3n_6 { get; init; } = c203N6;

    /// <summary>
    ///     Gets the C20:4n-3 fatty acid content of the food.
    /// </summary>
    public double? C20_4n_3 { get; init; } = c204N3;

    /// <summary>
    ///     Gets the C20:4n-6 fatty acid content of the food.
    /// </summary>
    public double? C20_4n_6 { get; init; } = c204N6;

    /// <summary>
    ///     Gets the C20:5n-3 (EPA) fatty acid content of the food.
    /// </summary>
    public double? C20_5n_3_EPA { get; init; } = c205N3Epa;

    /// <summary>
    ///     Gets the C22:5n-3 (DPA) fatty acid content of the food.
    /// </summary>
    public double? C22_5n_3_DPA { get; init; } = c225N3Dpa;

    /// <summary>
    ///     Gets the C22:6n-3 (DHA) fatty acid content of the food.
    /// </summary>
    public double? C22_6n_3_DHA { get; init; } = c226N3Dha;

    /// <summary>
    ///     Gets the omega-3 fatty acid content of the food.
    /// </summary>
    public double? Omega_3 { get; init; } = omega3;

    /// <summary>
    ///     Gets the omega-6 fatty acid content of the food.
    /// </summary>
    public double? Omega_6 { get; init; } = omega6;

    /// <summary>
    ///     Gets the cholesterol content of the food in milligrams.
    /// </summary>
    public double? KolesterolMg { get; init; } = kolesterolMg;

    /// <summary>
    ///     Gets the carbohydrate content of the food.
    /// </summary>
    public double? Karbohydrat { get; init; } = karbohydrat;

    /// <summary>
    ///     Gets the starch content of the food.
    /// </summary>
    public double? Stivelse { get; init; } = stivelse;

    /// <summary>
    ///     Gets the mono- and disaccharide content of the food.
    /// </summary>
    public double? MonoPlusDisakk { get; init; } = monoPlusDisakk;

    /// <summary>
    ///     Gets the added sugar content of the food.
    /// </summary>
    public double? SukkerTilsatt { get; init; } = sukkerTilsatt;

    /// <summary>
    ///     Gets the dietary fiber content of the food.
    /// </summary>
    public double? Kostfiber { get; init; } = kostfiber;

    /// <summary>
    ///     Gets the protein content of the food.
    /// </summary>
    public double? Protein { get; init; } = protein;

    /// <summary>
    ///     Gets the salt content of the food.
    /// </summary>
    public double? Salt { get; init; } = salt;

    /// <summary>
    ///     Gets the alcohol content of the food.
    /// </summary>
    public double? Alkohol { get; init; } = alkohol;

    /// <summary>
    ///     Gets the vitamin A content of the food in RAE.
    /// </summary>
    public double? VitaminARAE { get; init; } = vitaminArae;

    /// <summary>
    ///     Gets the retinol content of the food in micrograms.
    /// </summary>
    public double? RetinolMug { get; init; } = retinolMug;

    /// <summary>
    ///     Gets the beta-carotene content of the food in micrograms.
    /// </summary>
    public double? BetaKarotenMug { get; init; } = betaKarotenMug;

    /// <summary>
    ///     Gets the vitamin D content of the food in micrograms.
    /// </summary>
    public double? VitaminDMug { get; init; } = vitaminDMug;

    /// <summary>
    ///     Gets the vitamin E content of the food in alpha-TE.
    /// </summary>
    public double? VitaminEAlfaTE { get; init; } = vitaminEAlfaTe;

    /// <summary>
    ///     Gets the thiamine (vitamin B1) content of the food in milligrams.
    /// </summary>
    public double? TiaminMg { get; init; } = tiaminMg;

    /// <summary>
    ///     Gets the riboflavin (vitamin B2) content of the food in milligrams.
    /// </summary>
    public double? RiboflavinMg { get; init; } = riboflavinMg;

    /// <summary>
    ///     Gets the niacin (vitamin B3) content of the food in milligrams.
    /// </summary>
    public double? NiacinMg { get; init; } = niacinMg;

    /// <summary>
    ///     Gets the vitamin B6 content of the food in milligrams.
    /// </summary>
    public double? VitaminB6Mg { get; init; } = vitaminB6Mg;

    /// <summary>
    ///     Gets the folate content of the food in micrograms.
    /// </summary>
    public double? FolatMug { get; init; } = folatMug;

    /// <summary>
    ///     Gets the vitamin B12 content of the food in micrograms.
    /// </summary>
    public double? VitaminB12Mug { get; init; } = vitaminB12Mug;

    /// <summary>
    ///     Gets the vitamin C content of the food in milligrams.
    /// </summary>
    public double? VitaminCMg { get; init; } = vitaminCMg;

    /// <summary>
    ///     Gets the calcium content of the food in milligrams.
    /// </summary>
    public double? KalsiumMg { get; init; } = kalsiumMg;

    /// <summary>
    ///     Gets the iron content of the food in milligrams.
    /// </summary>
    public double? JernMg { get; init; } = jernMg;

    /// <summary>
    ///     Gets the sodium content of the food in milligrams.
    /// </summary>
    public double? NatriumMg { get; init; } = natriumMg;

    /// <summary>
    ///     Gets the potassium content of the food in milligrams.
    /// </summary>
    public double? KaliumMg { get; init; } = kaliumMg;

    /// <summary>
    ///     Gets the magnesium content of the food in milligrams.
    /// </summary>
    public double? MagnesiumMg { get; init; } = magnesiumMg;

    /// <summary>
    ///     Gets the zinc content of the food in milligrams.
    /// </summary>
    public double? SinkMg { get; init; } = sinkMg;

    /// <summary>
    ///     Gets the selenium content of the food in micrograms.
    /// </summary>
    public double? SelenMug { get; init; } = selenMug;

    /// <summary>
    ///     Gets the copper content of the food in milligrams.
    /// </summary>
    public double? KopperMg { get; init; } = kopperMg;

    /// <summary>
    ///     Gets the phosphorus content of the food in milligrams.
    /// </summary>
    public double? FosforMg { get; init; } = fosforMg;

    /// <summary>
    ///     Gets the iodine content of the food in micrograms.
    /// </summary>
    public double? JodMug { get; init; } = jodMug;

    /// <summary>
    ///     Creates a new instance of the <see cref="Food" /> class with the specified properties.
    /// </summary>
    /// <param name="foodId">The unique identifier of the food.</param>
    /// <param name="foodName">The name of the food.</param>
    /// <param name="spiseligDel">The edible portion of the food.</param>
    /// <param name="vann">The water content of the food.</param>
    /// <param name="kilojouleKj">The energy content in kilojoules.</param>
    /// <param name="kilokalorierKcal">The energy content in kilocalories.</param>
    /// <param name="fett">The fat content of the food.</param>
    /// <param name="mettet">The saturated fat content of the food.</param>
    /// <param name="c120G">The C12:0 fatty acid content of the food.</param>
    /// <param name="c140">The C14:0 fatty acid content of the food.</param>
    /// <param name="c160">The C16:0 fatty acid content of the food.</param>
    /// <param name="c180">The C18:0 fatty acid content of the food.</param>
    /// <param name="trans">The trans fat content of the food.</param>
    /// <param name="enumettet">The monounsaturated fat content of the food.</param>
    /// <param name="c161Sum">The C16:1 fatty acid content of the food.</param>
    /// <param name="c181Sum">The C18:1 fatty acid content of the food.</param>
    /// <param name="flerumettet">The polyunsaturated fat content of the food.</param>
    /// <param name="c182N6">The C18:2n-6 fatty acid content of the food.</param>
    /// <param name="c183N3">The C18:3n-3 fatty acid content of the food.</param>
    /// <param name="c203N3">The C20:3n-3 fatty acid content of the food.</param>
    /// <param name="c203N6">The C20:3n-6 fatty acid content of the food.</param>
    /// <param name="c204N3">The C20:4n-3 fatty acid content of the food.</param>
    /// <param name="c204N6">The C20:4n-6 fatty acid content of the food.</param>
    /// <param name="c205N3Epa">The C20:5n-3 (EPA) fatty acid content of the food.</param>
    /// <param name="c225N3Dpa">The C22:5n-3 (DPA) fatty acid content of the food.</param>
    /// <param name="c226N3Dha">The C22:6n-3 (DHA) fatty acid content of the food.</param>
    /// <param name="omega3">The omega-3 fatty acid content of the food.</param>
    /// <param name="omega6">The omega-6 fatty acid content of the food.</param>
    /// <param name="kolesterolMg">The cholesterol content of the food in milligrams.</param>
    /// <param name="karbohydrat">The carbohydrate content of the food.</param>
    /// <param name="stivelse">The starch content of the food.</param>
    /// <param name="monoPlusDisakk">The mono- and disaccharide content of the food.</param>
    /// <param name="sukkerTilsatt">The added sugar content of the food.</param>
    /// <param name="kostfiber">The dietary fiber content of the food.</param>
    /// <param name="protein">The protein content of the food.</param>
    /// <param name="salt">The salt content of the food.</param>
    /// <param name="alkohol">The alcohol content of the food.</param>
    /// <param name="vitaminArae">The vitamin A content of the food in RAE.</param>
    /// <param name="retinolMug">The retinol content of the food in micrograms.</param>
    /// <param name="betaKarotenMug">The beta-carotene content of the food in micrograms.</param>
    /// <param name="vitaminDMug">The vitamin D content of the food in micrograms.</param>
    /// <param name="vitaminEAlfaTe">The vitamin E content of the food in alpha-TE.</param>
    /// <param name="tiaminMg">The thiamine (vitamin B1) content of the food in milligrams.</param>
    /// <param name="riboflavinMg">The riboflavin (vitamin B2) content of the food in milligrams.</param>
    /// <param name="niacinMg">The niacin (vitamin B3) content of the food in milligrams.</param>
    /// <param name="vitaminB6Mg">The vitamin B6 content of the food in milligrams.</param>
    /// <param name="folatMug">The folate content of the food in micrograms.</param>
    /// <param name="vitaminB12Mug">The vitamin B12 content of the food in micrograms.</param>
    /// <param name="vitaminCMg">The vitamin C content of the food in milligrams.</param>
    /// <param name="kalsiumMg">The calcium content of the food in milligrams.</param>
    /// <param name="jernMg">The iron content of the food in milligrams.</param>
    /// <param name="natriumMg">The sodium content of the food in milligrams.</param>
    /// <param name="kaliumMg">The potassium content of the food in milligrams.</param>
    /// <param name="magnesiumMg">The magnesium content of the food in milligrams.</param>
    /// <param name="sinkMg">The zinc content of the food in milligrams.</param>
    /// <param name="selenMug">The selenium content of the food in micrograms.</param>
    /// <param name="kopperMg">The copper content of the food in milligrams.</param>
    /// <param name="fosforMg">The phosphorus content of the food in milligrams.</param>
    /// <param name="jodMug">The iodine content of the food in micrograms.</param>
    /// <returns>A new instance of the <see cref="Food" /> class.</returns>
    public static Food Created(
        FoodId foodId,
        string? foodName,
        double? spiseligDel,
        double? vann,
        double? kilojouleKj,
        double? kilokalorierKcal,
        double? fett,
        double? mettet,
        double? c120G,
        double? c140,
        double? c160,
        double? c180,
        double? trans,
        double? enumettet,
        double? c161Sum,
        double? c181Sum,
        double? flerumettet,
        double? c182N6,
        double? c183N3,
        double? c203N3,
        double? c203N6,
        double? c204N3,
        double? c204N6,
        double? c205N3Epa,
        double? c225N3Dpa,
        double? c226N3Dha,
        double? omega3,
        double? omega6,
        double? kolesterolMg,
        double? karbohydrat,
        double? stivelse,
        double? monoPlusDisakk,
        double? sukkerTilsatt,
        double? kostfiber,
        double? protein,
        double? salt,
        double? alkohol,
        double? vitaminArae,
        double? retinolMug,
        double? betaKarotenMug,
        double? vitaminDMug,
        double? vitaminEAlfaTe,
        double? tiaminMg,
        double? riboflavinMg,
        double? niacinMg,
        double? vitaminB6Mg,
        double? folatMug,
        double? vitaminB12Mug,
        double? vitaminCMg,
        double? kalsiumMg,
        double? jernMg,
        double? natriumMg,
        double? kaliumMg,
        double? magnesiumMg,
        double? sinkMg,
        double? selenMug,
        double? kopperMg,
        double? fosforMg,
        double? jodMug
        )
    {
        return new Food(
            foodId,
            foodName,
            spiseligDel,
            vann,
            kilojouleKj,
            kilokalorierKcal,
            fett,
            mettet,
            c120G,
            c140,
            c160,
            c180,
            trans,
            enumettet,
            c161Sum,
            c181Sum,
            flerumettet,
            c182N6,
            c183N3,
            c203N3,
            c203N6,
            c204N3,
            c204N6,
            c205N3Epa,
            c225N3Dpa,
            c226N3Dha,
            omega3,
            omega6,
            kolesterolMg,
            karbohydrat,
            stivelse,
            monoPlusDisakk,
            sukkerTilsatt,
            kostfiber,
            protein,
            salt,
            alkohol,
            vitaminArae,
            retinolMug,
            betaKarotenMug,
            vitaminDMug,
            vitaminEAlfaTe,
            tiaminMg,
            riboflavinMg,
            niacinMg,
            vitaminB6Mg,
            folatMug,
            vitaminB12Mug,
            vitaminCMg,
            kalsiumMg,
            jernMg,
            natriumMg,
            kaliumMg,
            magnesiumMg,
            sinkMg,
            selenMug,
            kopperMg,
            fosforMg,
            jodMug);
    }
}