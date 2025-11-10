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
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("description");
        this.DeclareOutput("distributor");
        this.DeclareOutput("has_default_path");
        this.DeclareOutput("name");
        this.DeclareOutput("owner");
        this.DeclareOutput("status");
        this.DeclareOutput("support_description");
        this.DeclareOutput("support_email");
        this.DeclareOutput("support_url");
        this.DeclareOutput("type");
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
