using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_regions.
/// </summary>
public class AwsRegionsDataSource : TerraformDataSource
{
    public AwsRegionsDataSource(string name) : base("aws_regions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("names");
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformProperty<bool>? AllRegions
    {
        get => GetProperty<TerraformProperty<bool>>("all_regions");
        set => this.WithProperty("all_regions", value);
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
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
