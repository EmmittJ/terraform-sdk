using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsSsmincidentsResponsePlan.
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// SsmAutomation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlock>? SsmAutomation
    {
        get => GetArgument<TerraformList<AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlock>>("ssm_automation");
        set => SetArgument("ssm_automation", value);
    }

}

/// <summary>
/// Block type for ssm_automation in AwsSsmincidentsResponsePlanActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssm_automation";

    /// <summary>
    /// The document_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentName is required")]
    public required TerraformValue<string> DocumentName
    {
        get => GetRequiredArgument<TerraformValue<string>>("document_name");
        set => SetArgument("document_name", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentVersion
    {
        get => GetArgument<TerraformValue<string>>("document_version");
        set => SetArgument("document_version", value);
    }

    /// <summary>
    /// The dynamic_parameters attribute.
    /// </summary>
    public TerraformMap<string>? DynamicParameters
    {
        get => GetArgument<TerraformMap<string>>("dynamic_parameters");
        set => SetArgument("dynamic_parameters", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The target_account attribute.
    /// </summary>
    public TerraformValue<string>? TargetAccount
    {
        get => GetArgument<TerraformValue<string>>("target_account");
        set => SetArgument("target_account", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsResponsePlanActionBlockSsmAutomationBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for incident_template in AwsSsmincidentsResponsePlan.
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIncidentTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incident_template";

    /// <summary>
    /// The dedupe_string attribute.
    /// </summary>
    public TerraformValue<string>? DedupeString
    {
        get => GetArgument<TerraformValue<string>>("dedupe_string");
        set => SetArgument("dedupe_string", value);
    }

    /// <summary>
    /// The impact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Impact is required")]
    public required TerraformValue<double> Impact
    {
        get => GetRequiredArgument<TerraformValue<double>>("impact");
        set => SetArgument("impact", value);
    }

    /// <summary>
    /// The incident_tags attribute.
    /// </summary>
    public TerraformMap<string>? IncidentTags
    {
        get => GetArgument<TerraformMap<string>>("incident_tags");
        set => SetArgument("incident_tags", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// NotificationTarget block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmincidentsResponsePlanIncidentTemplateBlockNotificationTargetBlock>? NotificationTarget
    {
        get => GetArgument<TerraformSet<AwsSsmincidentsResponsePlanIncidentTemplateBlockNotificationTargetBlock>>("notification_target");
        set => SetArgument("notification_target", value);
    }

}

/// <summary>
/// Block type for notification_target in AwsSsmincidentsResponsePlanIncidentTemplateBlock.
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsResponsePlanIncidentTemplateBlockNotificationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_target";

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    public required TerraformValue<string> SnsTopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

}


/// <summary>
/// Block type for integration in AwsSsmincidentsResponsePlan.
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integration";

    /// <summary>
    /// Pagerduty block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmincidentsResponsePlanIntegrationBlockPagerdutyBlock>? Pagerduty
    {
        get => GetArgument<TerraformList<AwsSsmincidentsResponsePlanIntegrationBlockPagerdutyBlock>>("pagerduty");
        set => SetArgument("pagerduty", value);
    }

}

/// <summary>
/// Block type for pagerduty in AwsSsmincidentsResponsePlanIntegrationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIntegrationBlockPagerdutyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pagerduty";

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
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

}


/// <summary>
/// Represents a aws_ssmincidents_response_plan Terraform resource.
/// Manages a aws_ssmincidents_response_plan resource.
/// </summary>
public partial class AwsSsmincidentsResponsePlan(string name) : TerraformResource("aws_ssmincidents_response_plan", name)
{
    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    public TerraformSet<string>? ChatChannel
    {
        get => GetArgument<TerraformSet<string>>("chat_channel");
        set => SetArgument("chat_channel", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    public TerraformSet<string>? Engagements
    {
        get => GetArgument<TerraformSet<string>>("engagements");
        set => SetArgument("engagements", value);
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
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<AwsSsmincidentsResponsePlanActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsSsmincidentsResponsePlanActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// IncidentTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncidentTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncidentTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncidentTemplate block(s) allowed")]
    public required TerraformList<AwsSsmincidentsResponsePlanIncidentTemplateBlock> IncidentTemplate
    {
        get => GetRequiredArgument<TerraformList<AwsSsmincidentsResponsePlanIncidentTemplateBlock>>("incident_template");
        set => SetArgument("incident_template", value);
    }

    /// <summary>
    /// Integration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Integration block(s) allowed")]
    public TerraformList<AwsSsmincidentsResponsePlanIntegrationBlock>? Integration
    {
        get => GetArgument<TerraformList<AwsSsmincidentsResponsePlanIntegrationBlock>>("integration");
        set => SetArgument("integration", value);
    }

}
