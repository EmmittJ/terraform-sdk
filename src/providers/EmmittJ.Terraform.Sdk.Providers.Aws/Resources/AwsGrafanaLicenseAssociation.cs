using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaLicenseAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_grafana_license_association resource.
/// </summary>
public class AwsGrafanaLicenseAssociation : TerraformResource
{
    public AwsGrafanaLicenseAssociation(string name) : base("aws_grafana_license_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("free_trial_expiration");
        SetOutput("license_expiration");
        SetOutput("grafana_token");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("region");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The grafana_token attribute.
    /// </summary>
    public TerraformProperty<string> GrafanaToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grafana_token");
        set => SetProperty("grafana_token", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaLicenseAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The free_trial_expiration attribute.
    /// </summary>
    public TerraformExpression FreeTrialExpiration => this["free_trial_expiration"];

    /// <summary>
    /// The license_expiration attribute.
    /// </summary>
    public TerraformExpression LicenseExpiration => this["license_expiration"];

}
