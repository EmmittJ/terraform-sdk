using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("free_trial_expiration");
        this.DeclareOutput("license_expiration");
    }

    /// <summary>
    /// The grafana_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GrafanaToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grafana_token");
        set => this.WithProperty("grafana_token", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
