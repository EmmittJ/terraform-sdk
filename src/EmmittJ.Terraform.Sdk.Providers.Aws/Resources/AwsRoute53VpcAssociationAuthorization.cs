using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_vpc_association_authorization resource.
/// </summary>
public class AwsRoute53VpcAssociationAuthorization : TerraformResource
{
    public AwsRoute53VpcAssociationAuthorization(string name) : base("aws_route53_vpc_association_authorization", name)
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    public TerraformProperty<string>? VpcRegion
    {
        get => GetProperty<TerraformProperty<string>>("vpc_region");
        set => this.WithProperty("vpc_region", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

}
