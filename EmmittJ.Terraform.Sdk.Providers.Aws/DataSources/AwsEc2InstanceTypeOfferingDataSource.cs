using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_instance_type_offering.
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeOfferingDataSource(string name) : base("aws_ec2_instance_type_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_type");
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
    /// The location_type attribute.
    /// </summary>
    public string? LocationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_type")?.Value;
        set => this.WithProperty("location_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public List<string>? PreferredInstanceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_instance_types")?.Value;
        set => this.WithProperty("preferred_instance_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

}
