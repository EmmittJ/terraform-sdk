using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_account resource.
/// </summary>
public class AwsMacie2Account : TerraformResource
{
    public AwsMacie2Account(string name) : base("aws_macie2_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("created_at");
        this.WithOutput("service_role");
        this.WithOutput("updated_at");
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? FindingPublishingFrequency
    {
        get => GetProperty<TerraformProperty<string>>("finding_publishing_frequency");
        set => this.WithProperty("finding_publishing_frequency", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformExpression ServiceRole => this["service_role"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
