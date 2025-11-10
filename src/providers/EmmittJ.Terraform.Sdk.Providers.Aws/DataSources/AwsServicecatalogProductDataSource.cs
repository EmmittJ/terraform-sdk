using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_servicecatalog_product.
/// </summary>
public class AwsServicecatalogProductDataSource : TerraformDataSource
{
    public AwsServicecatalogProductDataSource(string name) : base("aws_servicecatalog_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_time");
        this.WithOutput("description");
        this.WithOutput("distributor");
        this.WithOutput("has_default_path");
        this.WithOutput("name");
        this.WithOutput("owner");
        this.WithOutput("status");
        this.WithOutput("support_description");
        this.WithOutput("support_email");
        this.WithOutput("support_url");
        this.WithOutput("type");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogProductDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsServicecatalogProductDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    public TerraformExpression Distributor => this["distributor"];

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformExpression HasDefaultPath => this["has_default_path"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    public TerraformExpression SupportDescription => this["support_description"];

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public TerraformExpression SupportEmail => this["support_email"];

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public TerraformExpression SupportUrl => this["support_url"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
