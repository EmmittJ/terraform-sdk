using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
public class AwsAcmpcaCertificateAuthority : TerraformResource
{
    public AwsAcmpcaCertificateAuthority(string name) : base("aws_acmpca_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("arn");
        DeclareOutput("certificate");
        DeclareOutput("certificate_chain");
        DeclareOutput("certificate_signing_request");
        DeclareOutput("not_after");
        DeclareOutput("not_before");
        DeclareOutput("serial");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("enabled")?.Value;
        set => WithPropertyInternal("enabled", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    public string? KeyStorageSecurityStandard
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("key_storage_security_standard")?.Value;
        set => WithPropertyInternal("key_storage_security_standard", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    public double? PermanentDeletionTimeInDays
    {
        get => GetProperty<TerraformLiteralProperty&lt;double&gt;>("permanent_deletion_time_in_days")?.Value;
        set => WithPropertyInternal("permanent_deletion_time_in_days", value == null ? null : new TerraformLiteralProperty&lt;double&gt;(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags_all")?.Value;
        set => WithPropertyInternal("tags_all", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("type")?.Value;
        set => WithPropertyInternal("type", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public string? UsageMode
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("usage_mode")?.Value;
        set => WithPropertyInternal("usage_mode", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformExpression CertificateSigningRequest => this["certificate_signing_request"];

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformExpression NotAfter => this["not_after"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformExpression Serial => this["serial"];

}
