using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssmincidents_response_plan Terraform data source.
/// Retrieves information about a aws_ssmincidents_response_plan.
/// </summary>
public partial class AwsSsmincidentsResponsePlanDataSource(string name) : TerraformDataSource("aws_ssmincidents_response_plan", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Action
        => CreateReference("action");

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    public TerraformSet<string> ChatChannel
        => CreateReference("chat_channel");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    public TerraformSet<string> Engagements
        => CreateReference("engagements");

    /// <summary>
    /// The incident_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IncidentTemplate
        => CreateReference("incident_template");

    /// <summary>
    /// The integration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Integration
        => CreateReference("integration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

}
