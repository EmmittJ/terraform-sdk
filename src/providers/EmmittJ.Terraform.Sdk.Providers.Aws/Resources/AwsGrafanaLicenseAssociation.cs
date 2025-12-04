using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsGrafanaLicenseAssociation.
/// Nesting mode: single
/// </summary>
public class AwsGrafanaLicenseAssociationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_grafana_license_association Terraform resource.
/// Manages a aws_grafana_license_association resource.
/// </summary>
public partial class AwsGrafanaLicenseAssociation(string name) : TerraformResource("aws_grafana_license_association", name)
{
    /// <summary>
    /// The grafana_token attribute.
    /// </summary>
    public TerraformValue<string>? GrafanaToken
    {
        get => GetArgument<TerraformValue<string>>("grafana_token");
        set => SetArgument("grafana_token", value);
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
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformValue<string> LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The free_trial_expiration attribute.
    /// </summary>
    public TerraformValue<string> FreeTrialExpiration
        => AsReference("free_trial_expiration");

    /// <summary>
    /// The license_expiration attribute.
    /// </summary>
    public TerraformValue<string> LicenseExpiration
        => AsReference("license_expiration");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGrafanaLicenseAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGrafanaLicenseAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
