using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate in AwsWorkspaceswebTrustStore.
/// Nesting mode: set
/// </summary>
public class AwsWorkspaceswebTrustStoreCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformValue<string> Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
    }

    /// <summary>
    /// The not_valid_after attribute.
    /// </summary>
    public TerraformValue<string> NotValidAfter
    {
        get => new TerraformReference<string>(this, "not_valid_after");
    }

    /// <summary>
    /// The not_valid_before attribute.
    /// </summary>
    public TerraformValue<string> NotValidBefore
    {
        get => new TerraformReference<string>(this, "not_valid_before");
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}


/// <summary>
/// Represents a aws_workspacesweb_trust_store Terraform resource.
/// Manages a aws_workspacesweb_trust_store resource.
/// </summary>
public partial class AwsWorkspaceswebTrustStore(string name) : TerraformResource("aws_workspacesweb_trust_store", name)
{
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
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "associated_portal_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string> TrustStoreArn
    {
        get => new TerraformReference<string>(this, "trust_store_arn");
    }

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWorkspaceswebTrustStoreCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformSet<AwsWorkspaceswebTrustStoreCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}
