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
    public string? DataScanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_scan_id")?.Value;
        set => this.WithProperty("data_scan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    public TerraformExpression Rules => this["rules"];

}
