using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outpost_instance_type.
/// </summary>
public class AwsOutpostsOutpostInstanceTypeDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostInstanceTypeDataSource(string name) : base("aws_outposts_outpost_instance_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public List<string>? PreferredInstanceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_instance_types")?.Value;
        set => this.WithProperty("preferred_instance_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
