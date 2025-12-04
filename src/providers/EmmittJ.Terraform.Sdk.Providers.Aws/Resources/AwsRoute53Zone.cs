using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53Zone.
/// Nesting mode: single
/// </summary>
public class AwsRoute53ZoneTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc in AwsRoute53Zone.
/// Nesting mode: set
/// </summary>
public class AwsRoute53ZoneVpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc";

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    public TerraformValue<string>? VpcRegion
    {
        get => GetArgument<TerraformValue<string>>("vpc_region");
        set => SetArgument("vpc_region", value);
    }

}


/// <summary>
/// Represents a aws_route53_zone Terraform resource.
/// Manages a aws_route53_zone resource.
/// </summary>
public partial class AwsRoute53Zone(string name) : TerraformResource("aws_route53_zone", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The delegation_set_id attribute.
    /// </summary>
    public TerraformValue<string>? DelegationSetId
    {
        get => GetArgument<TerraformValue<string>>("delegation_set_id");
        set => SetArgument("delegation_set_id", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformList<string> NameServers
        => AsReference("name_servers");

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    public TerraformValue<string> PrimaryNameServer
        => AsReference("primary_name_server");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => AsReference("zone_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53ZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53ZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Vpc block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53ZoneVpcBlock>? Vpc
    {
        get => GetArgument<TerraformSet<AwsRoute53ZoneVpcBlock>>("vpc");
        set => SetArgument("vpc", value);
    }

}
