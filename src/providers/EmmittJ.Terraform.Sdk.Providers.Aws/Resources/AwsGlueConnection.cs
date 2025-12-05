using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for physical_connection_requirements in AwsGlueConnection.
/// Nesting mode: list
/// </summary>
public class AwsGlueConnectionPhysicalConnectionRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "physical_connection_requirements";

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The security_group_id_list attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIdList
    {
        get => GetArgument<TerraformSet<string>>("security_group_id_list");
        set => SetArgument("security_group_id_list", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Represents a aws_glue_connection Terraform resource.
/// Manages a aws_glue_connection resource.
/// </summary>
public partial class AwsGlueConnection(string name) : TerraformResource("aws_glue_connection", name)
{
    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public TerraformMap<string>? AthenaProperties
    {
        get => GetArgument<TerraformMap<string>>("athena_properties");
        set => SetArgument("athena_properties", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? CreateReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public TerraformMap<string>? ConnectionProperties
    {
        get => GetArgument<TerraformMap<string>>("connection_properties");
        set => SetArgument("connection_properties", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => GetArgument<TerraformValue<string>>("connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    public TerraformList<string>? MatchCriteria
    {
        get => GetArgument<TerraformList<string>>("match_criteria");
        set => SetArgument("match_criteria", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// PhysicalConnectionRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhysicalConnectionRequirements block(s) allowed")]
    public TerraformList<AwsGlueConnectionPhysicalConnectionRequirementsBlock>? PhysicalConnectionRequirements
    {
        get => GetArgument<TerraformList<AwsGlueConnectionPhysicalConnectionRequirementsBlock>>("physical_connection_requirements");
        set => SetArgument("physical_connection_requirements", value);
    }

}
