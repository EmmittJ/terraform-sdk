using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_zone_association resource.
/// </summary>
public class AwsRoute53ZoneAssociation : TerraformResource
{
    public AwsRoute53ZoneAssociation(string name) : base("aws_route53_zone_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("owning_account");
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    public string? VpcRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_region")?.Value;
        set => this.WithProperty("vpc_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public string? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id")?.Value;
        set => this.WithProperty("zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owning_account attribute.
    /// </summary>
    public TerraformExpression OwningAccount => this["owning_account"];

}
