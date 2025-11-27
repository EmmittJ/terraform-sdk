using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_privateca_certificate_template_iam_policy Terraform resource.
/// Manages a google_privateca_certificate_template_iam_policy resource.
/// </summary>
public partial class GooglePrivatecaCertificateTemplateIamPolicy(string name) : TerraformResource("google_privateca_certificate_template_iam_policy", name)
{
    /// <summary>
    /// The certificate_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateTemplate is required")]
    public required TerraformValue<string> CertificateTemplate
    {
        get => new TerraformReference<string>(this, "certificate_template");
        set => SetArgument("certificate_template", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

}
