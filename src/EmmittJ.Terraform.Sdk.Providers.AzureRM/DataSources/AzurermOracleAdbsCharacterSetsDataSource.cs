using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_oracle_adbs_character_sets.
/// </summary>
public class AzurermOracleAdbsCharacterSetsDataSource : TerraformDataSource
{
    public AzurermOracleAdbsCharacterSetsDataSource(string name) : base("azurerm_oracle_adbs_character_sets", name)
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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The character_sets attribute.
    /// </summary>
    public TerraformExpression CharacterSets => this["character_sets"];

}
