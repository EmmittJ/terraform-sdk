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
        get => GetRequiredArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string> Issuer
        => CreateReference("issuer");

    /// <summary>
    /// The not_valid_after attribute.
    /// </summary>
    public TerraformValue<string> NotValidAfter
        => CreateReference("not_valid_after");

    /// <summary>
    /// The not_valid_before attribute.
    /// </summary>
    public TerraformValue<string> NotValidBefore
        => CreateReference("not_valid_before");

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string> Subject
        => CreateReference("subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => CreateReference("thumbprint");

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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
        => CreateReference("associated_portal_arns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string> TrustStoreArn
        => CreateReference("trust_store_arn");

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWorkspaceswebTrustStoreCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformSet<AwsWorkspaceswebTrustStoreCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}
