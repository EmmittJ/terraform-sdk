using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for routing_configuration in AwsSfnAlias.
/// Nesting mode: list
/// </summary>
public class AwsSfnAliasRoutingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_configuration";

    /// <summary>
    /// The state_machine_version_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineVersionArn is required")]
    public required TerraformValue<string> StateMachineVersionArn
    {
        get => new TerraformReference<string>(this, "state_machine_version_arn");
        set => SetArgument("state_machine_version_arn", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSfnAlias.
/// Nesting mode: single
/// </summary>
public class AwsSfnAliasTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_sfn_alias Terraform resource.
/// Manages a aws_sfn_alias resource.
/// </summary>
public partial class AwsSfnAlias(string name) : TerraformResource("aws_sfn_alias", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// RoutingConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingConfiguration block(s) required")]
    public required TerraformList<AwsSfnAliasRoutingConfigurationBlock> RoutingConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsSfnAliasRoutingConfigurationBlock>>("routing_configuration");
        set => SetArgument("routing_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSfnAliasTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSfnAliasTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
