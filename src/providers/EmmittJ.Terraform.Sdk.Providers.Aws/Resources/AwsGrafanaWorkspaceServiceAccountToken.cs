using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_grafana_workspace_service_account_token Terraform resource.
/// Manages a aws_grafana_workspace_service_account_token resource.
/// </summary>
public partial class AwsGrafanaWorkspaceServiceAccountToken(string name) : TerraformResource("aws_grafana_workspace_service_account_token", name)
{
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondsToLive is required")]
    public required TerraformValue<double> SecondsToLive
    {
        get => GetArgument<TerraformValue<double>>("seconds_to_live");
        set => SetArgument("seconds_to_live", value);
    }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    public required TerraformValue<string> ServiceAccountId
    {
        get => GetArgument<TerraformValue<string>>("service_account_id");
        set => SetArgument("service_account_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    public TerraformValue<string> ExpiresAt
        => AsReference("expires_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
        => AsReference("key");

    /// <summary>
    /// The service_account_token_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccountTokenId
        => AsReference("service_account_token_id");

}
