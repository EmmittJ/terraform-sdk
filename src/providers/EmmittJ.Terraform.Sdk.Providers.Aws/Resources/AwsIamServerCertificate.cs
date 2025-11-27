using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsIamServerCertificate.
/// Nesting mode: single
/// </summary>
public class AwsIamServerCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_iam_server_certificate Terraform resource.
/// Manages a aws_iam_server_certificate resource.
/// </summary>
public partial class AwsIamServerCertificate(string name) : TerraformResource("aws_iam_server_certificate", name)
{
    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    public required TerraformValue<string> CertificateBody
    {
        get => new TerraformReference<string>(this, "certificate_body");
        set => SetArgument("certificate_body", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
    }

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    public TerraformValue<string> UploadDate
    {
        get => new TerraformReference<string>(this, "upload_date");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsIamServerCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsIamServerCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
