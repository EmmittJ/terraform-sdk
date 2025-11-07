using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public class AwsQuicksightAccountSubscription : TerraformResource
{
    public AwsQuicksightAccountSubscription(string name) : base("aws_quicksight_account_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_subscription_status");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ActiveDirectoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_directory_name");
        set => this.WithProperty("active_directory_name", value);
    }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AdminGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_group");
        set => this.WithProperty("admin_group", value);
    }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AdminProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_pro_group");
        set => this.WithProperty("admin_pro_group", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_method");
        set => this.WithProperty("authentication_method", value);
    }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AuthorGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("author_group");
        set => this.WithProperty("author_group", value);
    }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AuthorProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("author_pro_group");
        set => this.WithProperty("author_pro_group", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContactNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_number");
        set => this.WithProperty("contact_number", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirstName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_name");
        set => this.WithProperty("first_name", value);
    }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamIdentityCenterInstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_identity_center_instance_arn");
        set => this.WithProperty("iam_identity_center_instance_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LastName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_name");
        set => this.WithProperty("last_name", value);
    }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_email");
        set => this.WithProperty("notification_email", value);
    }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ReaderGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reader_group");
        set => this.WithProperty("reader_group", value);
    }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ReaderProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reader_pro_group");
        set => this.WithProperty("reader_pro_group", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Realm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("realm");
        set => this.WithProperty("realm", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    public TerraformExpression AccountSubscriptionStatus => this["account_subscription_status"];

}
