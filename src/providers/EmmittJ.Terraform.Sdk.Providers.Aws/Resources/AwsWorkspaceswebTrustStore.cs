using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: set
/// </summary>
public class AwsWorkspaceswebTrustStoreCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformProperty<string> Body
    {
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The not_valid_after attribute.
    /// </summary>
    public TerraformProperty<string>? NotValidAfter
    {
        set => SetProperty("not_valid_after", value);
    }

    /// <summary>
    /// The not_valid_before attribute.
    /// </summary>
    public TerraformProperty<string>? NotValidBefore
    {
        set => SetProperty("not_valid_before", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? Thumbprint
    {
        set => SetProperty("thumbprint", value);
    }

}

/// <summary>
/// Manages a aws_workspacesweb_trust_store resource.
/// </summary>
public class AwsWorkspaceswebTrustStore : TerraformResource
{
    public AwsWorkspaceswebTrustStore(string name) : base("aws_workspacesweb_trust_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("associated_portal_arns");
        SetOutput("tags_all");
        SetOutput("trust_store_arn");
        SetOutput("region");
        SetOutput("tags");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWorkspaceswebTrustStoreCertificateBlock>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformExpression TrustStoreArn => this["trust_store_arn"];

}
