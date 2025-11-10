using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataplex_data_quality_rules.
/// </summary>
public class GoogleDataplexDataQualityRulesDataSource : TerraformDataSource
{
    public GoogleDataplexDataQualityRulesDataSource(string name) : base("google_dataplex_data_quality_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("rules");
    }

    /// <summary>
    /// The data_scan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    public required TerraformProperty<string> DataScanId
    {
        get => GetProperty<TerraformProperty<string>>("data_scan_id");
        set => this.WithProperty("data_scan_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    public TerraformExpression Rules => this["rules"];

}
