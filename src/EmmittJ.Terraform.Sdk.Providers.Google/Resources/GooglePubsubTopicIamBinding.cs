using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_pubsub_topic_iam_binding resource.
/// </summary>
public class GooglePubsubTopicIamBinding : TerraformResource
{
    public GooglePubsubTopicIamBinding(string name) : base("google_pubsub_topic_iam_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The members attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Topic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic");
        set => this.WithProperty("topic", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
