using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

class MyForm : Form
{
    string myName;
    string message;

    public MyForm(string titleBar, string name)
    {
        this.Text = titleBar;
        this.myName = name;

        this.Size = new Size(500, 500);

        //controls
        Panel bottomPanel = new Panel();
        Label label = new Label();
        ListBox list = new ListBox();
        TextBox textBox = new TextBox();
        Label comment = new Label();
        Button button = new Button();
        Panel topPanel = new Panel(); 

        //bottom panel control
        bottomPanel.BackColor = Color.Blue;
        bottomPanel.Name = "Bottom Panel";
        bottomPanel.Width = this.Width;
        bottomPanel.Height = 250;
        bottomPanel.Dock = DockStyle.Bottom;
        

        //label control
        label.Text = name;
        label.Name = "Bottom Panel Label";


        
        //listbox control
        list.Name = "ListBox";
        list.Text = "List of Controls";
        list.Width = 100;
        list.Height = 200;
        list.Location = new Point(50, 20);
        
        //top panel control
        topPanel.BackColor = Color.Orange;
        topPanel.Dock = DockStyle.Fill;

        //'comment' label control
        comment.Name = "Top Panel Label";
        comment.Text = "Comment:";
        comment.Left = topPanel.Left;
        comment.Top = topPanel.Top;

        //textbox control
        textBox.Location = new Point(10, 30);
        textBox.Text = "Bye!";
        message = textBox.Text;
        textBox.Width = 300;
        textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

        //button control
        button.BackColor = Color.Blue;
        button.Text = "Click me";
        button.Location = new Point(310, 180);
        
        //adding controls to the form
        bottomPanel.Controls.Add(label);
        bottomPanel.Controls.Add(list);
        topPanel.Controls.Add(comment);
        this.Controls.Add(topPanel);
        topPanel.Controls.Add(textBox);
        topPanel.Controls.Add(button);
        this.Controls.Add(bottomPanel);

        
        
        //event handler
        button.Click += new EventHandler((s, e) => buttonClick(s, e, message));

        //loops for getting each control in the form
        foreach (Control control in this.Controls)
        {

            list.Items.Add(control.Name);
        }

        foreach (Control c in bottomPanel.Controls)
        {
            list.Items.Add(c.Name);
        }

        foreach (Control o in topPanel.Controls)
        {
            list.Items.Add(o.Name);
        }
    }

    void buttonClick(object sender, EventArgs e, string m)
    {
        MessageBox.Show("If you're reading this, I hope you get the bag. " + m);
        
    }
}

class Tester
{
    static void Main(string[] args)
    {
        MyForm f = new MyForm("Welcome to my Form!", "Teriq");

        Application.Run(f);
    }
}