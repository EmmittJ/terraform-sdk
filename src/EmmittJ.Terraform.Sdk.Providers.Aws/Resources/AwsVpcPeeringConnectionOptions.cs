using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
public class AwsVpcPeeringConnectionOptions : TerraformResource
{
    public AwsVpcPeeringConnectionOptions(string name) : base("aws_vpc_peering_connection_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_peering_connection_id");
        set => this.WithProperty("vpc_peering_connection_id", value);
    }

}
