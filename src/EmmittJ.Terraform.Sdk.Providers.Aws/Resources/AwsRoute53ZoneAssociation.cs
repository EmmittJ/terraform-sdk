using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53ZoneAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53ZoneAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53ZoneAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The owning_account attribute.
    /// </summary>
    public TerraformExpression OwningAccount => this["owning_account"];

}
