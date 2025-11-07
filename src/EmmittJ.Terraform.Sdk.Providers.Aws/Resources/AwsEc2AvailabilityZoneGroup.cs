using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_availability_zone_group resource.
/// </summary>
public class AwsEc2AvailabilityZoneGroup : TerraformResource
{
    public AwsEc2AvailabilityZoneGroup(string name) : base("aws_ec2_availability_zone_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptInStatus
    {
        get => GetProperty<TerraformProperty<string>>("opt_in_status");
        set => this.WithProperty("opt_in_status", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
