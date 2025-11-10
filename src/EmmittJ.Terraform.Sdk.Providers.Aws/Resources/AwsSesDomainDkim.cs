using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_domain_dkim resource.
/// </summary>
public class AwsSesDomainDkim : TerraformResource
{
    public AwsSesDomainDkim(string name) : base("aws_ses_domain_dkim", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dkim_tokens");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The dkim_tokens attribute.
    /// </summary>
    public TerraformExpression DkimTokens => this["dkim_tokens"];

}
