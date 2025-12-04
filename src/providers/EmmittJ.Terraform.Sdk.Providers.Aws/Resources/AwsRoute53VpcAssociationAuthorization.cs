using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53VpcAssociationAuthorization.
/// Nesting mode: single
/// </summary>
public class AwsRoute53VpcAssociationAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_route53_vpc_association_authorization Terraform resource.
/// Manages a aws_route53_vpc_association_authorization resource.
/// </summary>
public partial class AwsRoute53VpcAssociationAuthorization(string name) : TerraformResource("aws_route53_vpc_association_authorization", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    public TerraformValue<string> VpcRegion
    {
        get => GetArgument<TerraformValue<string>>("vpc_region") ?? AsReference("vpc_region");
        set => SetArgument("vpc_region", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53VpcAssociationAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53VpcAssociationAuthorizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
