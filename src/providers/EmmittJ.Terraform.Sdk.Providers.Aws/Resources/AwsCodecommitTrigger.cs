using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trigger in AwsCodecommitTrigger.
/// Nesting mode: set
/// </summary>
public class AwsCodecommitTriggerTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The branches attribute.
    /// </summary>
    public TerraformList<string>? Branches
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "branches").ResolveNodes(ctx));
        set => SetArgument("branches", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public TerraformList<string>? Events
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
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

}


/// <summary>
/// Represents a aws_codecommit_trigger Terraform resource.
/// Manages a aws_codecommit_trigger resource.
/// </summary>
public partial class AwsCodecommitTrigger(string name) : TerraformResource("aws_codecommit_trigger", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationId
    {
        get => new TerraformReference<string>(this, "configuration_id");
    }

    /// <summary>
    /// Trigger block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Trigger block(s) allowed")]
    public required TerraformSet<AwsCodecommitTriggerTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformSet<AwsCodecommitTriggerTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}
