using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_worklink_website_certificate_authority_association resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsWorklinkWebsiteCertificateAuthorityAssociation : TerraformResource
{
    public AwsWorklinkWebsiteCertificateAuthorityAssociation(string name) : base("aws_worklink_website_certificate_authority_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("website_ca_id");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public string? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate")?.Value;
        set => this.WithProperty("certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fleet_arn attribute.
    /// </summary>
    public string? FleetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_arn")?.Value;
        set => this.WithProperty("fleet_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The website_ca_id attribute.
    /// </summary>
    public TerraformExpression WebsiteCaId => this["website_ca_id"];

}
