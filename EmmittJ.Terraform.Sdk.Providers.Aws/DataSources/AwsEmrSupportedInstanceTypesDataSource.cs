using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_emr_supported_instance_types.
/// </summary>
public class AwsEmrSupportedInstanceTypesDataSource : TerraformDataSource
{
    public AwsEmrSupportedInstanceTypesDataSource(string name) : base("aws_emr_supported_instance_types", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    public string? ReleaseLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_label")?.Value;
        set => this.WithProperty("release_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
