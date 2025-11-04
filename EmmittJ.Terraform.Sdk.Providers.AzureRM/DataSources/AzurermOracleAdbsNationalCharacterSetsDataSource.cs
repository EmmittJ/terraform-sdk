using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_oracle_adbs_national_character_sets.
/// </summary>
public class AzurermOracleAdbsNationalCharacterSetsDataSource : TerraformDataSource
{
    public AzurermOracleAdbsNationalCharacterSetsDataSource(string name) : base("azurerm_oracle_adbs_national_character_sets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("character_sets");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The character_sets attribute.
    /// </summary>
    public TerraformExpression CharacterSets => this["character_sets"];

}
