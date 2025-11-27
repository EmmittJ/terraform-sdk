using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_certificate Terraform resource.
/// Manages a aws_transfer_certificate resource.
/// </summary>
public partial class AwsTransferCertificate(string name) : TerraformResource("aws_transfer_certificate", name)
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    public required TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string>? CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

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
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    public required TerraformValue<string> Usage
    {
        get => new TerraformReference<string>(this, "usage");
        set => SetArgument("usage", value);
    }

    /// <summary>
    /// The active_date attribute.
    /// </summary>
    public TerraformValue<string> ActiveDate
    {
        get => new TerraformReference<string>(this, "active_date");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
    }

    /// <summary>
    /// The inactive_date attribute.
    /// </summary>
    public TerraformValue<string> InactiveDate
    {
        get => new TerraformReference<string>(this, "inactive_date");
    }

}
